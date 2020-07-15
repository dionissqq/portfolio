import * as React from 'react';
type Props={
    numberOfSizes:object,
    func:any
    currentS:string
}
function Sizes({numberOfSizes,func,currentS}:Props ) {
    let arr:Array<any>=[]
    for (let size in numberOfSizes){
        let classStr="sizeBlock"
        if(size==currentS)
            classStr="sizeBlock sizeBlock--active"
        if (parseInt(numberOfSizes[size])>0){
            arr.push(<div className={classStr} onClick={(e)=>func(e)}>{size}</div>)
        }
        else{
            arr.push(<div className={classStr}>{size}</div>)
        }
    }
  return (
    <div>
        {arr}
    </div>
  );
}
export default Sizes;
