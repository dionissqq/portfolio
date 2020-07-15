import * as React from 'react';

function Menu(props) {
  return (
    <React.Fragment>
      <div style={{marginLeft:"10px"}}>
        <button className="MenuData__el" onClick={props.func}>toggle attributes</button>
        <select className="MenuData__el" onChange={(e)=>props.sortFunc(e)}>
          <option value="any">any</option>
          <option value="price up">price up</option>
          <option value="price down">price down</option>
        </select>  
      </div>
      <div style={{marginRight:"10px"}}>
        <input type="text" className="MenuData__el MenuData__el--search" placeholder="Search.." onInput={(e)=>{props.searchF(e)}}></input>
      </div>
      
    </React.Fragment>
  );
}
export default Menu;
