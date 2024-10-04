import { useEffect, useState } from "react";
import OsobaService from "../../services/OsobaService";
import { Button, Table } from "react-bootstrap";
import { Link } from "react-router-dom";
import { RouteNames } from "../../constants";


export default function OsobePregled() {
    const [osobe, setOsobe] = useState();

    async function dohvatiOsobe() {
        const odgovor = await OsobaService.get();
        if (odgovor.greska) {
            alert(odgovor.poruka);
            return;
        }
        setOsobe(odgovor.poruka);
    }

    // Ovaj hook (kuka) se izvodi dolaskom na stranicu Stanovi
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
                                <Button variant="danger" onClick={() => obrisi(osoba.sifra)}>Obriši</Button>
                            </td>
                        </tr>
                    ))}
                </tbody>
            </Table>
        </>
    );
}