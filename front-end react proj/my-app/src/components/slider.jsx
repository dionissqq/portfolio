import AwesomeSlider from 'react-awesome-slider';
import withAutoplay from 'react-awesome-slider/dist/autoplay';
import CoreStyles from 'react-awesome-slider/src/core/styles.scss';
import AnimationStyles from 'react-awesome-slider/src/styled/fold-out-animation/fold-out-animation.scss';
import React from 'react';

function Slider(){
  const AutoplaySlider = withAutoplay(AwesomeSlider);
  return(
    <div className="sliderDiv" >
    <AutoplaySlider
      play={true}
      cancelOnInteraction={false}
      interval={5000}
      cssModule={[CoreStyles,AnimationStyles]}
      bullets={false}
    >
      <div data-src="https://i.ytimg.com/vi/ym7yBpK-BZc/maxresdefault.jpg" />
      <div data-src="https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__340.jpg" />
      <div data-src="https://i.pinimg.com/564x/9e/d8/6f/9ed86f4d59363daf10f67d41282cab6b.jpg" />
      <div data-src="https://i.ytimg.com/vi/ym7yBpK-BZc/maxresdefault.jpg" />
  </AutoplaySlider>
  </div>
  )
}
export default Slider;