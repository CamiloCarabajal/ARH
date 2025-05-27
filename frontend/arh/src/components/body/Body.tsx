import "./Body.css"

const Body = () => {
  return (
    <div className="body-container">
      {/* Sección del Carrusel */}
      <section id="myCarousel" className="carousel slide mb-6" data-bs-ride="carousel">
        <div className="carousel-indicators">
          <button type="button" data-bs-target="#myCarousel" data-bs-slide-to="0" aria-label="Diapositiva 1"></button>
          <button type="button" data-bs-target="#myCarousel" data-bs-slide-to="1" className="active" aria-label="Diapositiva 2"></button>
          <button type="button" data-bs-target="#myCarousel" data-bs-slide-to="2" aria-label="Diapositiva 3"></button>
        </div>

        <div className="carousel-inner">
          <div className="carousel-item">
            <svg className="bd-placeholder-img" width="100%" height="500">
              <rect width="100%" height="100%" fill="var(--bs-secondary-color)"></rect>
            </svg>
            <div className="carousel-caption text-start">
              <h1>Titular de ejemplo.</h1>
              <p className="opacity-75">Contenido representativo para la primera diapositiva.</p>
              <p><a className="btn btn-lg btn-primary" href="#">Regístrate hoy</a></p>
            </div>
          </div>

          <div className="carousel-item active">
            <svg className="bd-placeholder-img" width="100%" height="500">
              <rect width="100%" height="100%" fill="var(--bs-secondary-color)"></rect>
            </svg>
            <div className="carousel-caption">
              <h1>Otro titular de ejemplo.</h1>
              <p>Texto representativo de marcador de posición.</p>
              <p><a className="btn btn-lg btn-primary" href="#">Conoce más</a></p>
            </div>
          </div>
        </div>

        <button className="carousel-control-prev" type="button" data-bs-target="#myCarousel" data-bs-slide="prev">
          <span className="carousel-control-prev-icon"></span>
        </button>
        <button className="carousel-control-next" type="button" data-bs-target="#myCarousel" data-bs-slide="next">
          <span className="carousel-control-next-icon"></span>
        </button>
      </section>

      {/* Sección de Marketing */}
      <section className="marketing container">
        <div className="row">
          <div className="col-lg-4 text-center">
            <svg className="bd-placeholder-img rounded-circle" width="140" height="140">
              <rect width="100%" height="100%" fill="var(--bs-secondary-color)"></rect>
            </svg>
            <h2 className="fw-normal">Título 1</h2>
            <p>Contenido representativo.</p>
            <p><a className="btn btn-secondary" href="#">Ver detalles »</a></p>
          </div>

          <div className="col-lg-4 text-center">
            <svg className="bd-placeholder-img rounded-circle" width="140" height="140">
              <rect width="100%" height="100%" fill="var(--bs-secondary-color)"></rect>
            </svg>
            <h2 className="fw-normal">Título 2</h2>
            <p>Contenido representativo.</p>
            <p><a className="btn btn-secondary" href="#">Ver detalles »</a></p>
          </div>

          <div className="col-lg-4 text-center">
            <svg className="bd-placeholder-img rounded-circle" width="140" height="140">
              <rect width="100%" height="100%" fill="var(--bs-secondary-color)"></rect>
            </svg>
            <h2 className="fw-normal">Título 3</h2>
            <p>Contenido representativo.</p>
            <p><a className="btn btn-secondary" href="#">Ver detalles »</a></p>
          </div>
        </div>
      </section>
    </div>
  );
};

export default Body;
