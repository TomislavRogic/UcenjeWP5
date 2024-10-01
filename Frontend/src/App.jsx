import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css';
import NavBarEdunova from './components/NavbarEdunova';
import { Container } from 'react-bootstrap';
import { Route, Routes} from 'react-router-dom';
import { RouteNames } from './constants';
import Pocetna from './pages/Pocetna';
import SmjeroviPregled from './pages/smjerovi/SmjeroviPregled';

function App() {
  return (
    <>
    
      <Container>
      <NavBarEdunova />
      <Routes>
      <Route path={RouteNames.HOME} element ={<Pocetna/>} />

      <Route path={RouteNames.SMJER_PREGLED} element ={<SmjeroviPregled/>} />
      </Routes>

      <hr/>
      &copy; Edunova
    

      </Container>
    </>
  );
}

export default App;