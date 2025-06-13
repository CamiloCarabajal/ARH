import Footer from "../footer/Footer"
import Header from "../header/Header"
import Hero from "../hero/Hero"
import Information from "../information/Information"
import Noticias from "../noticias/Noticias"

const Landing = () => {
  return (
    <div className="bg-white">
     <Header/>
     <Hero/>
     <Information/>
     <Noticias/>
     <Footer/>
     

    </div>
  )
}

export default Landing