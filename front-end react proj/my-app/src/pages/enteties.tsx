import React,  { Component ,PureComponent, useState, useEffect } from 'react';
import Goods from "../components/goods"
import Attributes from "../components/attributes"
import Menu from "../components/menu"
import GoodManager from "../modules/goods"
import AttributeWithValue from "../modules/atWValue"
import SortingMethods from "../modules/sortingEnum"
import Pagination from "../components/pagination"
import { useParams } from 'react-router-dom';


const historyPushEvent=new Event("my-event"); 
let sortM=SortingMethods.Any
let substring=""

function onCheckboxToggle(e:any,name:string,value:string){
  let urlParams = new URLSearchParams(window.location.search);
  let flag=false;
  for(var pair of urlParams.entries()) {
    if(pair[0]==name){
      let values=pair[1].split(',')
      if (!values.includes(value)){
        if(e.target.checked){
          let newvalue=pair[1]+','+value
          urlParams.set(name, newvalue)
        }
      }else{
        if(!e.target.checked){
          values.splice(values.indexOf(value),1)
          let newstr="";
          values.map((el)=>{
            if (newstr!="")
              newstr+=","
            newstr+=el
          })
          if(newstr==""){
            urlParams.delete(name)
            break
          }
          urlParams.set(name,newstr)
        }

      }
      flag=true
      break
    }
  }
  if(!flag){
    if(e.target.checked){
      urlParams.set(name, value)
    }
  }
  window.history.pushState({page: 1}, "products", "?"+urlParams.toString());
  document.dispatchEvent(historyPushEvent);
}

function getClassNameForPage(check,over){
  if (check && !over)
    return "centeredPage"
  else
    return "centeredPage centeredPage--no"
}

function Enteties(props) {
  let {nowPage}=useParams()
    const [displayAttr,setDisplayAttr]=useState(true)
    const [attrsOver,setAttrsOver]=useState(false)
    const [data,setData]=useState(GoodManager.getAll())
    const [loading,setLoading]=useState(true)

    const [nOfPages,setNOfPages]=useState(nowPage)
    
    function priceFilterChange(e){
      console.log(e.target)
    }
    const ChangeSortingMethod=(e)=>{
      console.log(e.target.value)
      nowPage=1
      props.history.push("/products/1"+window.location.search)
      console.log(e.target.value)
      sortM=e.target.value
      getAndSetData()
    }
    document.addEventListener('my-event', (e)=> {
      props.history.push("/products/1"+window.location.search)
      getAndSetData()
    })
    window.addEventListener('popstate', (e)=>{
      getAndSetData()
    })
    function getAndSetData(){
      let newData=onlyGetData()
      setData(newData.elements)
      setNOfPages(newData.nOfPages)
    }
    function SearchByName(e){
      substring=e.target.value
      getAndSetData()
    }
    function onlyGetData(){ 
      let urlParams = new URLSearchParams(window.location.search);
      let attributes:AttributeWithValue[]=[];
      attributes.push({
        name:"name",
        value:substring
      })
      for(let pair of urlParams.entries()) {
        let obj={
          name:pair[0],
          value:pair[1]
        }
        attributes.push(obj)
      }
      let newData=GoodManager.getGoodsPage(attributes,sortM,nowPage)
      return newData
    }
    const toggleAttrs=()=>{
      console.log("clicked")
      let dsp=true
      if(displayAttr)
        dsp=false
      setDisplayAttr(dsp)
      
    }
    const changeSize=()=>{
      console.log(window.innerWidth % 200)
      let attr=false;
      if(window.innerWidth<=580)
        attr=true
      setAttrsOver(attr)

    }
    window.addEventListener('resize',changeSize);

    useEffect(()=>{
      changeSize()
    },[])
    useEffect(()=>{
      console.log(props.match.params.nowPage)
      nowPage=props.match.params.nowPage
      getAndSetData()
    },[props.match.params.nowPage])
    return (
      <div className="productPage">
        <div className={getClassNameForPage(displayAttr,attrsOver)}>
          <Attributes priceF={priceFilterChange} checkBoxFunc={onCheckboxToggle} display={displayAttr}  over={attrsOver} />
            <div className="menuPrPag">
              <div className="MenuData">
                <Menu func={toggleAttrs} sortFunc={ChangeSortingMethod} searchF={SearchByName}/>
              </div>
              <Goods goods={data as GoodManager[]} />
              <Pagination page={nowPage} pageNumber={nOfPages} />
            </div>
        </div>
        </div>
    );
  }
  export default Enteties;
  