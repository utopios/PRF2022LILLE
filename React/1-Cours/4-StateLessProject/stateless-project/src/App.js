import NavBar from './components/NavBarComponent/NavBar';
import Header from './components/HeaderComponent/Header';

import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';
import Footer from './components/FooterComponent/Footer';

function App() {
  return (
    <div className="App">
      <Header />
      <NavBar />
      <Footer />
    </div>
  );
}

export default App;
