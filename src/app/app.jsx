
import React from "react";
import { Link, Outlet, useNavigate } from "react-router-dom";
import bild from "../../assets/MuskelMat2.png";
import CookieConsent from "react-cookie-consent";
import LogIn from "./components/LogIn.jsx";
import Footer from "./components/Footer.jsx"




let loggedIn = null;

export default function App() {

  const navigate = useNavigate();

  if (localStorage.getItem("loggedin")) {
    loggedIn = JSON.parse(localStorage.getItem("loggedin"));
  }



  return (
    <div className="appDiv">
      {(loggedIn === true)
        ?
        <>
          <header>
            <img src={bild} alt=""></img>
            <nav className="menu">
              <Link className="link" to="/recipes">Recept</Link>
              <Link className="link" to="/savedrecipes">Sparade Recept</Link>
              <Link className="link" to="/weeklymenu">Veckomatsedel</Link>
              <Link className="link" to="/contact">Kontakt</Link>
              <Link className="link" to="/calculatemenu">Få din Veckomatsedel</Link>
              <button onClick={() => { localStorage.removeItem("loggedin"); navigate("/", { replace: true }); location.reload(); }}>Logga ut</button>
            </nav>
          </header>
          <Outlet />
          <CookieConsent
            location="bottom"
            buttonText="Härligt, tack så mycket!"
            cookieName="MuskelMatCookie"
            style={{ background: "#2B373B", textAlign: "center", fontSize: "20px" }}
            buttonStyle={{ color: "#4e503b", fontSize: "20px" }}
            expires={1}
          >
            Vi bjuder på kakor!{" "}
            <span style={{ fontSize: "10px" }}>Tänk på kalorierna bara...</span>
          </CookieConsent>
          
        </>
        :

        <LogIn />

      }
      <Footer />
    </div>
  );
}