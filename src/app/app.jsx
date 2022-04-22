
import React from "react";
import { Link, Outlet } from "react-router-dom";
import bild from "../../assets/MuskelMat2.png";


export default function App() {
  return (
    <div>
      <header>
      <img src={bild} alt=""></img>
      <nav className="menu">
        <Link className="link" to="/recipes">Recept</Link>
        <Link className="link" to="/savedrecipes">Sparade Recept</Link>
        <Link className="link" to="/weeklymenu">Veckomatsedel</Link>
        <Link className="link" to="/contact">Kontakt</Link>
        <Link className="link" to="/calculatemenu">Få din Veckomatsedel</Link>
      </nav>
      </header>
      <Outlet />
    </div>
  );
}