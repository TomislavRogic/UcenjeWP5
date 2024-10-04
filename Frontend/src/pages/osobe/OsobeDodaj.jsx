import { useState } from "react";
import OsobaService from "../../services/OsobaService";
import { Button, Row, Col, Form } from "react-bootstrap";
import { Link, useNavigate } from "react-router-dom";
import { RouteNames } from "../../constants";

export default function OsobeDodaj() {
    const navigate = useNavigate();
    const [formData,setFormData] = useState({
        email: '',
        ime: '',
        prezime: '', 
    });

    function handleChange(e) {
        const { name, value } = e.target;
        setFormData(prevState => ({
            ...prevState,
            [name]: value
        }));
    }

    async function obradiSubmit(e) {
        e.preventDefault();
        const odgovor = await OsobaService.dodaj(formData);
        if (odgovor.greska) {
            alert(odgovor.poruka);
            return;
        }
        navigate(RouteNames.OSOBA_PREGLED);
    }

    return (
        <>
            Dodavanje osobe
            <Form onSubmit={obradiSubmit}>
            <Form.Group controlId="email">
                    <Form.Label>Email</Form.Label>
                    <Form.Control 
                    type="email" 
                    name="email" 
                    value={formData.email}
                    onChange={handleChange}
                    required />
                </Form.Group>

                <Form.Group controlId="ime">
                    <Form.Label>Ime</Form.Label>
                    <Form.Control 
                    type="text" 
                    name="ime"
                    value={formData.ime}
                    onChange={handleChange} 
                    required />
                </Form.Group>

                <Form.Group controlId="prezime">
                    <Form.Label>Prezime</Form.Label>
                    <Form.Control 
                    type="text" 
                    name="prezime" 
                    value={formData.prezime}
                    onChange={handleChange}
                    required />
                </Form.Group>

                <Row className="akcije">
                    <Col xs={6} sm={12} md={3} lg={6} xl={6} xxl={6}>
                        <Link to={RouteNames.OSOBA_PREGLED} className="btn btn-danger siroko">Odustani</Link>
                    </Col>
                    <Col xs={6} sm={12} md={9} lg={6} xl={6} xxl={6}>
                        <Button variant="success" type="submit" className="siroko">Dodaj osobu</Button>
                    </Col>
                </Row>
            </Form>
        </>
    );
}