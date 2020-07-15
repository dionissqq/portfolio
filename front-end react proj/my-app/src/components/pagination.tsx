import * as React from 'react';
import { Link } from 'react-router-dom';
type Props={
    page:number,
    pageNumber:number
}
function Pag({page=1,pageNumber=1}:Props) {
    let arr:Array<any>=[]
    if(page!=1)
        arr.push(<Link to={"/products/"+(parseInt(page.toString())-1).toString()+window.location.search} replace ><div className="MenuData__el">&#171;</div></Link>)
    if (page>=4)
        arr.push("...") 
    for(let i=page-3;i<page+4 && i<=pageNumber;i++){
        if(i>0){
            if (i==page)
                arr.push(<Link to={"/products/"+i+window.location.search} replace ><div className="MenuData__el MenuData__el--samePage">{i.toString()}</div></Link>)
            else
                arr.push(<Link to={"/products/"+i+window.location.search} replace ><div className="MenuData__el">{i.toString()}</div></Link>)
        }
    }
    if(page<pageNumber-4){
        arr.push("...")
        arr.push(pageNumber.toString()) 
    }
    if(page!=pageNumber)
        arr.push(<Link to={"/products/"+(parseInt(page.toString())+1).toString()+window.location.search} replace ><div className="MenuData__el">&#187;</div></Link>)
  return (
      <div className="pagination-space">
        <div className="pagination">
            {arr}
        </div>
      </div>
    
  );
}
export default Pag;
