import React from 'react';
import { NavButton } from './NavbarElements'

export class Navbar extends React.Component {
    render() {
        return (
            <nav class="menu">

            <div><NavButton name="recipes">Recept</NavButton></div>
            <div><NavButton name="savedRecipes">Sparade Recept</NavButton></div>
            <div><NavButton name="contact">Kontakt</NavButton></div>
        </nav>
        )
    }
}