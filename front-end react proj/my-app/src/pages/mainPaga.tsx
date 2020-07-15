import * as React from 'react';
import logoImg from '../data/img/logo.png'
import Slider from "../components/slider"
function Main() {
  return (
    <div className="mainPage">
        <div className="mainPage__slider">
            <Slider />
        </div>
        <div className="mainPage__notSlider">
            <div className="mainPage__notSlider__logo">
                <img src={logoImg} alt="logo"/>
                <p>My site - the best you can</p>
                    <p>afford now</p>
            </div>
            <div className="mainPage__notSlider__image">
                <img src="https://cdn.shopify.com/s/files/1/0262/8540/8314/products/mockup-b49b7ec2_720x.jpg?v=1589779112" alt="prod1"/>
                <img src="https://i.etsystatic.com/14643726/r/il/e3959b/2011365951/il_570xN.2011365951_ls8h.jpg" alt="prod2"/>
            </div>
        </div>
    </div>
  );
}
export default Main;