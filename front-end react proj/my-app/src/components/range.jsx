import React from 'react';
import ReactDOM from 'react-dom';
import  { Range } from 'rc-slider';
// We can just import Slider or Range to reduce bundle size
// import Slider from 'rc-slider/lib/Slider';
// import Range from 'rc-slider/lib/Range';
import 'rc-slider/assets/index.css';

function Rng(myprops) {
  if (myprops.priceF==undefined)
    console.log(myprops.name)
    return (
        <div>
          dfvbfdkjnv
        <Range 
          allowCross={false}
          defaultValue={[0,100]}
          pushable={true}
          onChange={(e)=>{myprops.priceF(e)}}
          ariaValueTextFormatterGroupForHandles={(values)=>console.log(values[0])}
        />
      </div>
    );
  }
  export default Rng;
  