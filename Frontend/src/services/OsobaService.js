import { HttpService } from "./HttpService";

async function get(){
    return await HttpService.get('/Osoba')
    .then((odgovor)=>{
        //console.log(odgovor.data)
        //console.table(odgovor.data)
        return {greska: false, poruka: odgovor.data}
    })
    .catch((e)=>{
        //console.log(e)
        return {greska: true, poruka: 'Problem kod dohvaćanja osoba'}   
    })
}

async function brisanje(sifra){
    return await HttpService.delete('/Osoba/' + sifra)
    .then(()=>{
        return {greska: false, poruka: 'Obrisano'}
    })
    .catch(()=>{
        return {greska: true, poruka: 'Problem kod brisanja osoba'}   
    })
}

export default {
    get,
    brisanje
}