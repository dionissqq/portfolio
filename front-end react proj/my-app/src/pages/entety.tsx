import React, { useState }  from 'react';
import Sizes from "../components/sizes"
import ChooseN from "../components/chooseNumber"
import GoodManager from "../modules/goods"
const WidH={
    width:"100%",
    height:"auto"
}
const HeiW={
    height:"100%",
    width:"auto"
}
function Product(props) {
    let el:GoodManager=GoodManager.getById(props.match.params.id)
    const [size,setSize]=useState("s")
    const [num,setNum]=useState("0")
    const [image,setImage]=useState(0)
    const [displayIm,setDisplayIm]=useState(WidH)
    function AddToCart(){
        if (parseInt(num)!=0)
            props.addFunc(props.match.params.id,size,parseInt(num))
    }
    function onLoad(e){
        setDisplayIm(e.target.width>e.target.height ? WidH : HeiW)
    }
    function nextImage(){
        console.log("clicked")
        if(image<el.images.length-1)
            setImage(image+1)
    }
    function prevImage(){
        if(image>0)
            setImage(image-1)    
    }
    console.log(props.match.params.id)
    

    let attrs=el.attributes.map(at=>
        <tr>
            <td>{at.name}</td>
            <td>{at.value}</td>
        </tr>
        )
    const sizeClick=(e)=>{
        console.log(e.target.innerText)
        setSize(e.target.innerText)
    }
    const ChangeN=(value)=>{
        setNum(value)
    }
    let numbers=el.numberOfSizes
  return (
      <div className="productPage">
          <div className="centeredPage centeredPage--product">
              <div className="prImagesAndData">
                  <div className="prImagesAndData__images">
                    <span className="prImagesAndData__images__helper"></span>
                         <img src={el.images[image]} style={displayIm} onLoad={e=>{onLoad(e)}}  alt=""/>
                    <div className="prImagesAndData__images__arrow prImagesAndData__images__arrow--left" onClick={()=>{prevImage()}}><img className="arrowIcon" src="https://cdn.onlinewebfonts.com/svg/img_439970.png" /></div>
                    <div className="prImagesAndData__images__arrow prImagesAndData__images__arrow--right" onClick={()=>{nextImage()}}><img className="arrowIcon arrowIcon--right" src="https://cdn.onlinewebfonts.com/svg/img_439970.png" /></div>
                </div>
                  <div className="prImagesAndData__data">
                    <h2>{el.name}</h2>
                    <h4>price : {el.price}</h4> 

                    <Sizes numberOfSizes={numbers}
                    func={sizeClick}
                    currentS={size}
                        />
                  <p/><pre> quantity</pre>      
                <p/><ChooseN max={numbers[size]} func={ChangeN}/> 
                <p/><div className="prImagesAndData__data__buttonAndPrice"><button className="addBtn" disabled={parseInt(num)==0} onClick={AddToCart}>add to cart</button><pre>  {el.price*parseInt(num)} to pay</pre></div>  
                  </div> 
              </div>
              <div className="prCharacteristics">
                <p>Characteristics</p>
                <table>
                    {attrs}
                </table>
              </div>
          </div>
      </div>
  );
}
export default Product;
