import { Container, Row, Col, Button, Image } from "react-bootstrap";
import { useNavigate } from "react-router-dom";


const Information = () => {

  const navigate = useNavigate();

    const features = [
    {
      title: "Partidos",
      text: "Torneo RosarinoS",
      route: "/partidos",
      Image: "https://images.noz-mhn.de/img/23527365/crop/cbase_16_9-w748-h420/1389706862/1407990704/9e367433da4d57a5c8e2359da451334d.jpg"
    },
    {
      title: "Clubes",
      text: "Queres saber en que equipo te podes sumar? entra a esta seccion para enterarte de toda la informacion.",
      route: "/clubes",
      Image: "https://handballargentina.org/cah/wp-content/uploads/2019/05/MG_9918.jpg"
    },
    {
      title: "Arbitros",
      text: "Informacion sobre nuestros aribtros rosarinos. Quienes son? Como formar parte de ellos? Cursos y mas en esta seccion",
       route: "/arbitros",
       Image: "https://thumbs.dreamstime.com/b/handball-referee-show-yellow-card-showing-romanian-league-play-off-game-dinamo-bucharest-dunarea-calarasi-54230100.jpg"
    },
  ];

  return (
    <Container fluid className="py-5 bg-secondary m-0">
      <Row>
        {features.map((feature, index) => (
          <Col key={index} md={4} className="text-center mb-4">
            <Image
              src={feature.Image}
              roundedCircle
              width="140"
              height="140"
              className="mb-3"
              alt="placeholder"
            />
            <h2>{feature.title}</h2>
            <p>{feature.text}</p>
                        <Button variant="dark" onClick={() => navigate(feature.route)}>
              Ver detalles »
            </Button>

          </Col>
        ))}
      </Row>
    </Container>
  );
}

export default Information