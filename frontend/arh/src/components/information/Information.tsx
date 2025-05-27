import { Container, Row, Col, Button, Image } from "react-bootstrap";

const Information = () => {
    const features = [
    {
      title: "Partidos",
      text: "Donec sed odio dui. Etiam porta sem malesuada magna mollis euismod. Nullam id dolor id nibh ultricies vehicula ut id elit.",
    },
    {
      title: "Clubes",
      text: "Duis mollis, est non commodo luctus, nisi erat porttitor ligula, eget lacinia odio sem nec elit.",
    },
    {
      title: "Arbitros",
      text: "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Vestibulum id ligula porta felis euismod semper.",
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
            <Button variant="secondary">View details »</Button>
          </Col>
        ))}
      </Row>
    </Container>
  );
}

export default Information