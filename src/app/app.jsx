
import React from "react";
import { Link, Outlet } from "react-router-dom";
import bild from "../../assets/MuskelMat2.png";
import CookieConsent from "react-cookie-consent";


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
      <CookieConsent
        location="bottom"
        buttonText="Härligt, tack så mycket!"
        cookieName="MuskelMatCookie"
        style={{ background: "#2B373B", textAlign: "center", fontSize:"20px" }}
        buttonStyle={{ color: "#4e503b", fontSize: "20px" }}
        expires={150}
      >
        Vi bjuder på kakor!{" "}
        <span style={{ fontSize: "10px" }}>Tänk på kalorierna bara!</span>
      </CookieConsent>
    </div>
  );
}