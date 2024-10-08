import VozacService from "../../services/VozacService"
import { Button, Row, Col, Form } from "react-bootstrap";
import moment from "moment";
import { Link, useNavigate } from "react-router-dom";
import { RouteNames } from "../../constants";


export default function VozaciDodaj(){

    const navigate = useNavigate()

    async function dodaj(vozac) {
        //console.log(smjer)
        //console.log(JSON.stringify(smjer))
        const odgovor = await VozacService.dodaj(vozac)
        if(odgovor.greska){
            alert(odgovor.poruka)
            return;
        }
        navigate(RouteNames.VOZAC_PREGLED)
    }

    function obradiSubmit(e){ // e je event
        e.preventDefault(); // nemoj odraditi zahtjev na server
        let podaci = new FormData(e.target)
        //console.log(podaci.get('naziv'))
        dodaj({
            ime: podaci.get('ime'),
            prezime: get('prezime'),
            OIB: get('oib'),
            
            
        })
    }

    return(
        <>
        Dodavanje vozac
        <Form onSubmit={obradiSubmit}>

            <Form.Group controlId="ime">
                <Form.Label>Ime</Form.Label>
                <Form.Control type="text" name="ime" required />
            </Form.Group>

            <Form.Group controlId="prezime">
                <Form.Label>Prezime</Form.Label>
                <Form.Control type="text" name="prezime" required />
            </Form.Group>

            <Form.Group controlId="oib">
                <Form.Label>Oib</Form.Label>
                <Form.Control type="text" name="oib" required />
            </Form.Group>

           


            

            

        <Row className="akcije">
            <Col xs={6} sm={12} md={3} lg={6} xl={6} xxl={6}>
            <Link to={RouteNames.VOZAC_PREGLED} 
            className="btn btn-danger siroko">Odustani</Link>
            </Col>
            <Col xs={6} sm={12} md={9} lg={6} xl={6} xxl={6}>
            <Button variant="success"
            type="submit"
            className="siroko">Dodaj vozaca</Button>
            </Col>
        </Row>
        </Form>
        </>
    )
}