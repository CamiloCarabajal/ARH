const Noticias = () => {
  return (
    <div>
      <div className="card mb-3">
        <img src="https://media.sitioandino.com.ar/p/20f189024800725e94f1e4ca62e84a93/adjuntos/335/imagenes/000/621/0000621719/1200x630/smart/imagepng.png" className="card-img-top" alt="Noticia 1" />
        <div className="card-body">
          <h5 className="card-title">Card title</h5>
          <p className="card-text">
            This is a wider card with supporting text below as a natural lead-in to additional content.
            This content is a little bit longer.
          </p>
          <p className="card-text">
            <small className="text-body-secondary">Last updated 3 mins ago</small>
          </p>
        </div>
      </div>

      <div className="card">
        <div className="card-body">
          <h5 className="card-title">Card title</h5>
          <p className="card-text">
            This is a wider card with supporting text below as a natural lead-in to additional content.
            This content is a little bit longer.
          </p>
          <p className="card-text">
            <small className="text-body-secondary">Last updated 3 mins ago</small>
          </p>
        </div>
        <img src="https://3.bp.blogspot.com/-hThh2-5nbQQ/W90LdQaTXQI/AAAAAAAA8dk/O1FrkpES7x8WKQyrtT1dND0VnNUaJL-uwCLcBGAs/s1600/_MG_9951.jpg" className="card-img-bottom" alt="Noticia 2" />
      </div>
    </div>
  );
};

export default Noticias;
