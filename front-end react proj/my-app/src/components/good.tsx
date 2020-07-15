import * as React from 'react';
import '../styles/products.css'
import {Link} from 'react-router-dom'
function Gd(props) {
  return (
    
    <li className="products__product">
        
          <Link to={"/product/"+props.element.id}>

            <div className="image" style={{backgroundImage:"url("+props.element.images[0]+")"}}/>
            <h1>{props.element.name}</h1>
            <h2>price : {props.element.price}</h2>
            <div className="informations">
                <p>any aditional information you want here 
                  bla bla bla bla lorem ipsum bacon yeah</p>
            </div>

            </Link>
    </li>
  );
}
export default Gd;
