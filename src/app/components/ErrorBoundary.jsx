import React from "react";
import {Link} from "react-router-dom";

export default class ErrorBoundary extends React.Component {
  constructor(props) {
    super(props);
    this.state = { hasError: false };
  }

  static getDerivedStateFromError(error) {
    return { hasError: true };
  }


  render() {
    if (this.state.hasError) {
      return (
        <>
          <h1>Någonting gick fel.</h1>
          <Link to="/">
          <button onClick={()=> this.setState({hasError: false})}>Gå tillbaka</button>
          </Link>

        </>);

    }

    return this.props.children;
  }
}