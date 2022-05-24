import React from "react";
import PropTypes from "prop-types";


export default class ReadMoreButton extends React.Component {

    render() {
        return (
            <button onClick={this.props.onClick}>{this.props.status}</button>
        )
    }
}

ReadMoreButton.propTypes = {
    status: PropTypes.string,
    onclick: PropTypes.func
}