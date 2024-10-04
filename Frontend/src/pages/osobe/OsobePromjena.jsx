
import { Button, Row, Col, Form } from "react-bootstrap";
import moment from "moment";
import { Link, useNavigate, useParams } from "react-router-dom";
import { RouteNames } from "../../constants";
import { useEffect, useState } from "react";


export default function OsobePromjena(){

    const [osoba,setOsoba] = useState({})
    const navigate = useNavigate()
    const routeParams = useParams()

    async function dohvatiOsoba(){
        const odgovor = await OsobaService.getBySifra(routeParams.sifra);
        if(odgovor.greska){
            alert(odgovor.poruka)
            return
        }
        //debugger; // ovo radi u Chrome inspect (ali i ostali preglednici)
        let s = odgovor.poruka
        s.izvodiSeOd = moment.utc(s.izvodiSeOd).format('yyyy-MM-DD')
        setOsoba(s)
    } 

    useEffect(()=>{
        dohvatiOsoba();
     },[])

     async function promjena(osoba) {
        //console.log(osoba)
        //console.log(JSON.stringify(osoba))
        const odgovor = await OsobaService.promjena(routeParams.sifra,osoba)
        if(odgovor.greska){
            alert(odgovor.poruka)
            return;
        }
        navigate(RouteNames.OSOBA_PROMJENA)
    }

    function obradiSubmit(e){ // e je event
        e.preventDefault(); // nemoj odraditi zahtjev na server
        let podaci = new FormData(e.target)
        //console.log(podaci.get('email'))
        promjena({
            email: podaci.get('email'),
            ime: podaci.get('ime'),
            prezime: podaci.get('prezime')
        })
    }

    return(
        <>
        Promjena osobe
        <Form onSubmit={obradiSubmit}>

            <Form.Group controlId="email">
                <Form.Label>Email</Form.Label>
                <Form.Control 
                type="email" 
                name="email" 
                required defaultValue={osoba.email}/>
            </Form.Group>

            <Form.Group controlId="ime">
                <Form.Label>Ime</Form.Label>
                <Form.Control 
                type="text" 
                name="ime" 
                required defaultValue={osoba.ime}/>
            </Form.Group>

            <Form.Group controlId="prezime">
                <Form.Label>Prezime</Form.Label>
                <Form.Control 
                type="text" 
                name="prezime" 
                required defaultValue={osoba.prezime}/>
            </Form.Group>

        <Row className="akcije">
            <Col xs={6} sm={12} md={3} lg={6} xl={6} xxl={6}>
            <Link to={RouteNames.OSOBA_PREGLED} 
            className="btn btn-danger siroko">Odustani</Link>
            </Col>
            <Col xs={6} sm={12} md={9} lg={6} xl={6} xxl={6}>
            <Button variant="success"
            type="submit"
            className="siroko">Promjeni osobu</Button>
            </Col>
        </Row>
        </Form>
        </>
    )
}