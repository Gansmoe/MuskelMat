import React from "react";


export default class ReadMoreButton extends React.Component {

    render() {
        return (
            <button>{this.props.status}</button>
        )
    }
}