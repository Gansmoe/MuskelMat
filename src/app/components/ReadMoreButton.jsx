import React from "react";


export default class ReadMoreButton extends React.Component {

    render() {
        return (
            <button onClick={this.props.onClick}>{this.props.status}</button>
        )
    }
}