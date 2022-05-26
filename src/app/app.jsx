
import React, { useContext, useEffect } from "react";
import { Link, Outlet, useNavigate } from "react-router-dom";
import bild from "../../assets/MuskelMat2.png";
import LogIn from "./components/LogIn.jsx";
import Footer from "./components/Footer.jsx"
import UserProvider from './context/UserContext.js';
import UserContext from './context/UserContext.js'




let loggedIn = null;

export const App = () => {

  const user = useContext(UserContext)

  const navigate = useNavigate();

  if (localStorage.getItem("loggedin")) {
    loggedIn = JSON.parse(localStorage.getItem("loggedin"));
  }



  return (
    <>
      {(loggedIn === true)
        ?
        <>
          <header>
            <img src={bild} alt=""></img>
            <nav className="menu">
              <p>{user.name}</p>
              <Link className="link" to="/recipes">Recept</Link>
              <Link className="link" to="/savedrecipes">Sparade Recept</Link>
              <Link className="link" to="/weeklymenu">Veckomatsedel</Link>
              <Link className="link" to="/calculatemenu">Få din Veckomatsedel</Link>
              {(user.isAdmin === true)
                ?
                <Link className="link" to="/addrecipe">Lägg till recept</Link>
                :
                <p></p>
              }
              <Link className="link" to="/contact">Kontakt</Link>
              <button onClick={() => { localStorage.removeItem("loggedin"); navigate("/", { replace: true }); location.reload(); }}>Logga ut</button>
            </nav>
          </header>
          <Outlet />
        </>
        :
        <LogIn />
      }
      <Footer />
    </>
  );
}