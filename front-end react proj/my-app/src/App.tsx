import React,{useState} from 'react';
import './App.css';
import ReactDOM from 'react-dom';
import './index.css';
import OverHeader from './components/overheader';
import Header from './components/header';
import * as serviceWorker from './serviceWorker';
import './styles/styles.css'
import MainPage from "./pages/mainPaga"
import About from './pages/about'
import Products from "./pages/enteties"
import Product from "./pages/entety"
import OrderItemClass from "./modules/orderClass"
import GoodsManager from "./modules/goods"
import OrderPage from "./pages/orderPage"
import Footer  from './components/footer'
import {
  BrowserRouter as Router,
  Switch,
  Route,
  BrowserRouter
} from "react-router-dom";

let order:Array<OrderItemClass>=[]

function App() {
  const [num,setNum]=useState(0)
  function addPr(id:number,size:string,numberOfGood:number){
    let sameEl=order.find((element, index, array)=>{
      return (element.item.id==id.toString() && element.size==size)
    })
    if (sameEl==undefined)
        order.push(new OrderItemClass(GoodsManager.getById(id.toString()),size,numberOfGood))
    else{
      order[order.indexOf(sameEl)].number+=numberOfGood;
    }
    setNum(num+numberOfGood)
  }
  function reset(){
    order=[]
    setNum(0)
  }
  return (
    <React.Fragment>
    <BrowserRouter>
    <div className="content">
    <OverHeader />
    <Header numberToOrder={num}/>
    
    <Switch>
          <Route path="/about">
            <About/>
          </Route>
          <Route  path="/products/:nowPage" render={(props)=><Products {...props} />}>
          </Route>
          <Route path="/product/:id" render={(props)=><Product {...props} addFunc={addPr}/>}>
          </Route>
          <Route path="/order">
            <OrderPage elmentsToBuy={order} buy={reset}/>
          </Route>
          <Route path="/">
            <MainPage />
          </Route>
      </Switch>
      </div>
      <Footer/>
    </BrowserRouter>
  </React.Fragment>
  );
}

export default App;
