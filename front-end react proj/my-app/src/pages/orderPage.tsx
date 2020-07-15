import * as React from 'react';
import OrderItemClass from "../modules/orderClass"
import NothingPage from "./noOrderPage"

type Props={
    elmentsToBuy:Array<OrderItemClass>
    buy:any;
}
function Order({elmentsToBuy,buy}:Props) {
    let sum=0;
    let arr= elmentsToBuy.map(el=>{
        sum+=el.item.price*el.number
        return(
        <div className="itemToOrder">
            <div className="itemToOrder__image">
                <span className="itemToOrder__image__helper"></span>
                <img src={el.item.images[0]} width="200px" alt=""/>
            </div>
            <div className="itemToOrder__data">
                <h1>{el.item.name}</h1>
                <p/>size <div className="sizeBlock">{el.size}</div>
                <p/>number {el.number}
                <h3>to pay:{el.item.price*el.number}</h3>
            </div>
        </div>)
        }
        )

  return (
    <div className="orderPage">
        {elmentsToBuy.length==0 ?<NothingPage/>:
        <div className="centeredOrderPage">
            {arr}
            <div className="buyBlock">
                <p>{sum} to pay </p>
                <button className="buyBtn" onClick={buy}>buy</button>
            </div>
        </div>
        }
        
    </div>
  );
}
export default Order;
