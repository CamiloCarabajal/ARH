import { Container, Row, Col, Button, Image } from "react-bootstrap";
import { useNavigate } from "react-router-dom";


const Information = () => {

  const navigate = useNavigate();

    const features = [
    {
      title: "Partidos",
      text: "Donec sed odio dui. Etiam porta sem malesuada magna mollis euismod. Nullam id dolor id nibh ultricies vehicula ut id elit.",
      route: "/partidos",
    },
    {
      title: "Clubes",
      text: "Duis mollis, est non commodo luctus, nisi erat porttitor ligula, eget lacinia odio sem nec elit.",
      route: "/clubes",
    },
    {
      title: "Arbitros",
      text: "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Vestibulum id ligula porta felis euismod semper.",
       route: "/arbitros",
    },
  ];

  return (
    <Container fluid className="py-5 bg-secondary m-0">
      <Row>
        {features.map((feature, index) => (
          <Col key={index} md={4} className="text-center mb-4">
            <Image
              src="https://via.placeholder.com/140"
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