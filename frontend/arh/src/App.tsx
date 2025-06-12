
import './App.css'
import Landing from './components/landing/Landing'
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Partidos from './components/partidos/Partidos';
 import Clubes from './components/clubes/Clubes';
 import Arbitros from './components/arbitros/Arbitros';



function App() {
 // const [count, setCount] = useState(0)

  return (
    <Router>
      <Routes>
        <Route path="/" element={<Landing />} />
        <Route path="/partidos" element={<Partidos />} />
        <Route path="/clubes" element={<Clubes />} />
        <Route path="/arbitros" element={<Arbitros />} /> 
      </Routes>
    </Router>
  )
}

export default App
