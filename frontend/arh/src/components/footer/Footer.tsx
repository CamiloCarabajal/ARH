import './footer.css';

const Footer = () => {
  return (
    <footer className="footer-container">
      <div className="footer-content">
        <a href="/" className="footer-logo">
          <svg className="bi" width="30" height="24"></svg>
        </a>
        <span>© 2023 Company, Inc</span>
      </div>

      <ul className="footer-links">
        <li><a href="#"><svg className="bi" width="24" height="24"></svg></a></li>
        <li><a href="#"><svg className="bi" width="24" height="24"></svg></a></li>
        <li><a href="#"><svg className="bi" width="24" height="24"></svg></a></li>
      </ul>
    </footer>
  );
};

export default Footer;
