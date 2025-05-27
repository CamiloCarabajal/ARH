import Carousel from "react-bootstrap/Carousel";
import imagen1 from "../../images/logoArh.png";
import imagen2 from "../../images/torneoNacional1.jpg";
import imagen3 from "../../images/concentracion.jpg";

const Hero = () => {
  return (
    <>
      <Carousel className="bg-danger">
        <Carousel.Item>
          <img
            className="d-block w-100 "
            src={imagen1}
            alt="First slide"
            style={{ objectFit: "fill",height: "50vh" }}
          />
          <Carousel.Caption>
            <h3></h3>
            <p></p>
          </Carousel.Caption>
        </Carousel.Item>
        <Carousel.Item>
          <img
            className="d-block w-100 "
            src={imagen2}
            alt="First slide"
            style={{ objectFit: "fill",height: "50vh"}}
          />
          <Carousel.Caption>
            <h3></h3>
            <p></p>
          </Carousel.Caption>
        </Carousel.Item>
        <Carousel.Item>
          <img
            className="d-block w-100"
            src={imagen3}
            alt="First slide"
            style={{ objectFit: "fill" ,height: "50vh"}}
          />
          <Carousel.Caption>
            <h3></h3>
            <p>
            </p>
          </Carousel.Caption>
        </Carousel.Item>
      </Carousel>
    </>
  );
};

export default Hero;
