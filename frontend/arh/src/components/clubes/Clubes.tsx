
import { Container, Row, Col, Card, Button } from "react-bootstrap";
import { FaWhatsapp } from "react-icons/fa";

interface Club {
  id: number;
  name: string;
  image: string;
  address: string;
  schedule: string;
  whatsapp: string;
}

const clubes: Club[] = [
  {
    id: 1,
    name: "Club Atlético Rosario",
    image: "https://via.placeholder.com/150",
    address: "Calle Falsa 123",
    schedule: "Lunes a Viernes de 18 a 22hs",
    whatsapp: "3411234567",
  },
  {
    id: 2,
    name: "Club Deportivo Central",
    image: "https://via.placeholder.com/150",
    address: "Av. Siempre Viva 742",
    schedule: "Martes y Jueves de 17 a 21hs",
    whatsapp: "3412345678",
  },
  {
    id: 3,
    name: "Handball Norte",
    image: "https://via.placeholder.com/150",
    address: "Bv. Oroño 500",
    schedule: "Lunes, Miércoles y Viernes de 19 a 22hs",
    whatsapp: "3413456789",
  },
  {
    id: 4,
    name: "Sur Handball Club",
    image: "https://via.placeholder.com/150",
    address: "San Martín 850",
    schedule: "Sábados de 10 a 14hs",
    whatsapp: "3414567890",
  },
  {
    id: 5,
    name: "Asociación Este",
    image: "https://via.placeholder.com/150",
    address: "Mitre 1000",
    schedule: "Martes y Jueves de 18 a 20hs",
    whatsapp: "3415678901",
  },
  {
    id: 6,
    name: "Rosario Oeste Handball",
    image: "https://via.placeholder.com/150",
    address: "Corrientes 1234",
    schedule: "Miércoles y Viernes de 19 a 21hs",
    whatsapp: "3416789012",
  },
  {
    id: 7,
    name: "Club Central Cordoba",
    image: "https://via.placeholder.com/150",
    address: "Córdoba 555",
    schedule: "Lunes a Viernes de 17 a 21hs",
    whatsapp: "3417890123",
  },
  {
    id: 8,
    name: "Barrio Unido",
    image: "https://via.placeholder.com/150",
    address: "Santa Fe 222",
    schedule: "Sábados de 9 a 13hs",
    whatsapp: "3418901234",
  },
  {
    id: 9,
    name: "Nueva Aurora",
    image: "https://via.placeholder.com/150",
    address: "Urquiza 789",
    schedule: "Martes y Jueves de 18 a 22hs",
    whatsapp: "3419012345",
  },
];

const Clubes = () => {
  return (
    <Container className="my-5">
      <h1 className="text-center mb-4">
        Clubes de la Asociación Rosarina de Handball
      </h1>
      <Row>
        {clubes.map((club) => {
          const whatsappLink = `https://wa.me/549${club.whatsapp}?text=Hola!%20Quisiera%20consultar%20sobre%20handball%20en%20${encodeURIComponent(
            club.name
          )}`;
          return (
            <Col key={club.id} md={4} className="mb-4">
              <Card className="h-100 shadow">
                <Card.Img
                  variant="top"
                  src={club.image}
                  alt={club.name}
                  style={{ height: "200px", objectFit: "cover" }}
                />
                <Card.Body className="d-flex flex-column">
                  <Card.Title className="text-center">{club.name}</Card.Title>
                  <Card.Text>
                    <strong>Dirección:</strong> {club.address}
                    <br />
                    <strong>Horarios:</strong> {club.schedule}
                  </Card.Text>
                  <div className="mt-auto">
                    <Button
                      variant="success"
                      href={whatsappLink}
                      target="_blank"
                      className="w-100"
                    >
                      <FaWhatsapp className="me-2" />
                      Contactar por WhatsApp
                    </Button>
                  </div>
                </Card.Body>
              </Card>
            </Col>
          );
        })}
      </Row>
    </Container>
  );
};

export default Clubes;
