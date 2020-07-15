import * as React from 'react';
import GoogleMapReact from 'google-map-react';
 

function AnyComp(props:any){
    return(
        <div>{props.text}</div>
    )
}

function Map() {
    let defaultProps = {
    center: {
        lat: 50.7398786,
        lng: 25.2639648
    },
    zoom: 11
    };
  return (
    <div className="map">
        <GoogleMapReact
          defaultCenter={defaultProps.center}
          defaultZoom={defaultProps.zoom}
        >
          <AnyComp
            lat={50.7398786}
            lng={25.2639648}
            text="Our office"
            />
        </GoogleMapReact>
    </div>
  );
}
export default Map;
