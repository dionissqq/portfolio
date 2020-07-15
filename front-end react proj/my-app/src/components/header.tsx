import  React from 'react';
import {Link} from 'react-router-dom'
import a from "../modules/attribute"
type Props={
  numberToOrder:number;
}
function Header({numberToOrder}:Props){
  console.log(a.getAll())
  return (
    <nav className="header">
      <ul className="headerMenu">
          <div className="topmenu">
          <li><Link to="/"><div className="nav__el">main</div></Link></li>
            <li><Link to="/products/1" className="active"> <div className="nav__el">catalog</div> <span className="fa fa-angle-down"></span></Link>
              <ul className="submenu">
                <li><Link to="/products/1?type=t-shirt"> check t-shirts</Link></li>
                <li><Link to="/products/1?type=jeans">check jeans</Link></li>
                <li><Link to="/products/1">new <span className="fa fa-angle-down"></span></Link>
                <ul className="submenu">
                    <li><Link to="/product/1">new DOKIMAKURA</Link></li>
                    <li><Link to="/product/2">new black t-shIrt</Link></li>
                  </ul>
                </li>
              </ul>
            </li>
            <li><Link to="/about"><div className="nav__el">contacts
            </div></Link></li>
          </div>
  <Link to="/order"><div className="nav__el nav__el--last">cart <span className="icon"></span><i>{numberToOrder}</i>
    </div></Link>
  </ul>
    </nav>
  );
}

export default Header;

