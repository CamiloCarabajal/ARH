import imagen from "../../images/Momentos Handball.png";
import imagen2 from "../../images/KempaHandball.png";
import imagen3 from "../../images/PibesHandball.png";

const Noticias = () => {
  return (
    <div>
      <hr className="featurette-divider"></hr>
      <div className="row featurette">
        {" "}
        <div className="col-md-7">
          {" "}
          <h2 className="featurette-heading fw-normal lh-1">
            First featurette heading.{" "}
            <span className="text-body-secondary">It’ll blow your mind.</span>
          </h2>{" "}
          <p className="lead">
            Some great placeholder content for the first featurette here.
            Imagine some exciting prose here.
          </p>{" "}
        </div>{" "}
        <div className="col-md-5">
          {" "}
          <img
            src={imagen}
            alt="Descripción de la imagen"
            className="bd-placeholder-img bd-placeholder-img-lg featurette-image img-fluid mx-auto"
            width="500"
            height="500"
          />
        </div>{" "}
      </div>
      <hr className="featurette-divider"></hr>
      <div className="row featurette">
        {" "}
        <div className="col-md-7 order-md-2">
          {" "}
          <h2 className="featurette-heading fw-normal lh-1">
            Oh yeah, it’s that good.{" "}
            <span className="text-body-secondary">See for yourself.</span>
          </h2>{" "}
          <p className="lead">
            Another featurette? Of course. More placeholder content here to give
            you an idea of how this layout would work with some actual
            real-world content in place.
          </p>{" "}
        </div>{" "}
        <div className="col-md-5 order-md-1">
          {" "}
          <img
            src={imagen2}
            alt="Descripción de la imagen"
            className="bd-placeholder-img bd-placeholder-img-lg featurette-image img-fluid mx-auto"
            width="500"
            height="500"
          />
        </div>{" "}
      </div>
      <hr className="featurette-divider"></hr>
      <div className="row featurette">
        {" "}
        <div className="col-md-7">
          {" "}
          <h2 className="featurette-heading fw-normal lh-1">
            First featurette heading.{" "}
            <span className="text-body-secondary">It’ll blow your mind.</span>
          </h2>{" "}
          <p className="lead">
            Some great placeholder content for the first featurette here.
            Imagine some exciting prose here.
          </p>{" "}
        </div>{" "}
        <div className="col-md-5">
          {" "}
          <img
            src={imagen3}
            alt="Descripción de la imagen"
            className="bd-placeholder-img bd-placeholder-img-lg featurette-image img-fluid mx-auto"
            width="500"
            height="500"
          />
        </div>{" "}
      </div>
      <hr className="featurette-divider"></hr>
    </div>
  );
};

export default Noticias;
