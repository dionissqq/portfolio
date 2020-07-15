import * as React from 'react';
import Attr from "../modules/attribute"
import AttrComponent from "./attribute"
import { prependOnceListener } from 'cluster';
import Range from "./range"

type AttrsDisplayProps={
  checkBoxFunc:any;
  priceF:any,
  display:boolean,
  over:boolean
}

function Atts({
  checkBoxFunc,
  priceF,
  display =true,
  over=false
}:AttrsDisplayProps) {
  
    let goods=Attr.getAll();
    let arr=goods.map(el=>
        <AttrComponent element={el} func={checkBoxFunc} />
    )

    if(display==true)
      if(over==true)
        return (
          <div className="attributes attributes--over">
              {arr}
          </div>
        );
      else{
        return (
          <div className="attributes">
              {arr}
          </div>
        );
      }
    else
        return (null);
}
export default Atts;
