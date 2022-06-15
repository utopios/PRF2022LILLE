import NavBar from './components/NavBarComponent/NavBar';
import Header from './components/HeaderComponent/Header';
import {React, useState} from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';
import Footer from './components/FooterComponent/Footer';

function App() {
  const [cart,updateCart] = useState([]);
  return (
    <div className="App">
      <Header />
      <NavBar cart={cart} updateCart= {updateCart}/>
      <Footer />
    </div>
  );
}

export default App;
