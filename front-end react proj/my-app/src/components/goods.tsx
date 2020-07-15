import * as React from 'react';
import Good from "../modules/goods"
import ProductComponent from "./good"
import '../styles/products.css'
import NoRes from "../pages/noResultsPage"
type Iprops={
  goods:Good[]
}
function Gds({goods}:Iprops) {
    let arr=goods.map(el=>
        <ProductComponent element={el}/>
    )
  return (
    <div className="products">
        {goods.length==0 ? <NoRes/>:null}
        {arr}
     </div>
  );
}
export default Gds;
