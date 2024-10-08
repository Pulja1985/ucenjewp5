import 'bootstrap/dist/css/bootstrap.min.css'
import Container from 'react-bootstrap/Container';
import './App.css'
import NavBarEdunova from './components/NavBarPrijavnice';
import { Route, Routes } from 'react-router-dom';
import { RouteNames } from './constants';
import Pocetna from './pages/Pocetna';
import VozaciPregled from './pages/Vozaci/VozacPregled';
import VozaciDodaj from './pages/Vozaci/VozacDodaj';
import VozaciPromjena from './pages/Vozaci/VozacPromjena';


function App() {

  return (
    <>
    <Container>
      <NavBarEdunova />
      <Routes>
        <Route path={RouteNames.HOME} element={<Pocetna/>} />

        <Route path={RouteNames.VOZAC_PREGLED} element={<VozaciPregled/>}/>
        <Route path={RouteNames.VOZAC_NOVI} element={<VozaciDodaj/>}/>
        <Route path={RouteNames.VOZAC_PROMJENA} element={<VozaciPromjena/>}/>

      </Routes>
      <hr/>
      &copy; Edunova
    </Container>
    
    </>
  )
}

export default App
