import { useEffect, useState } from "react";
import OsobaService from "../../services/OsobaService";
import { Button, Table } from "react-bootstrap";
import { Link, useNavigate } from "react-router-dom";
import { RouteNames } from "../../constants";

export default function OsobePregled() {
    const navigate = useNavigate();
    const [osobe, setOsobe] = useState([]);

    async function dohvatiOsobe() {
        const odgovor = await OsobaService.get();
        if (odgovor.greska) {
            alert(odgovor.poruka);
            return;
        }
        setOsobe(odgovor.poruka);
    }

    useEffect(() => {
        dohvatiOsobe();
    }, []);

    function obrisi(sifra) {
        if (!confirm('Sigurno obrisati')) {
            return;
        }
        brisanjeOsoba(sifra);
    }

    async function brisanjeOsoba(sifra) {
        const odgovor = await OsobaService.brisanje(sifra);
        if (odgovor.greska) {
            alert(odgovor.poruka);
            return;
        }
        dohvatiOsobe();
    }

    return (
        <>
            <Link to={RouteNames.OSOBA_DODAJ} className="btn btn-success siroko">
                Dodaj novu osobu
            </Link>
            <Table striped bordered hover responsive>
                <thead>
                    <tr>
                        <th>Email</th>
                        <th>Ime</th>
                        <th>Prezime</th>
                        <th>Akcija</th>
                    </tr>
                </thead>
                <tbody>
                    {osobe && osobe.map((osoba, index) => (
                        <tr key={index}>
                            <td>{osoba.email}</td>
                            <td>{osoba.ime}</td>
                            <td>{osoba.prezime}</td>
                            <td>
                            <Button variant="danger" size="sm" className="w-100 mb-2" onClick={() => obrisi(osoba.sifra)}>Obriši</Button>
                            <Button variant="primary" size="sm" className="w-100" onClick={() => navigate(`/osobe/${osoba.sifra}`)}>Promjena</Button>
                            </td>
                        </tr>
                    ))}
                </tbody>
            </Table>
        </>
    );
}