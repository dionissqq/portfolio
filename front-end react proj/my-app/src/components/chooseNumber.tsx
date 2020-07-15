import React, { useState }  from 'react';
import NumericInput from 'rc-input-number';
import 'rc-input-number/assets/index.css';
function Choose(props) {
    const [count, setCount] = useState(0);
    const onChange = (value) => {
        props.func(value)
        setCount( value );
      }
  return (
    <NumericInput
        aria-label="Simple number input example"
        min={0}
        max={props.max}
        value={count}
        style={{ width: 100 }}
        onChange={onChange}/>
  );
}
export default Choose;
