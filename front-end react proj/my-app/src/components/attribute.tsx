import * as React from 'react';

type Iprops={
  element:any,
  func:any
}

function atr({element,func}:Iprops) {
    const arr=element.values.map(el=>
    <p><input type="checkbox" name={element.name} value={el} onChange={(e)=>func(e,element.name,el)}/>{el}</p>
        )
  return (
    <div className="attributes__attribute">
        <h1>{element.name}</h1>
         {arr}
    </div>
  );
}
export default atr;
