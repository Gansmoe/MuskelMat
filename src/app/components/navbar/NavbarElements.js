import React from 'react';


export class NavButton extends React.Component {
    
    
    render() {
        return (
            <button
                className={'NavButton' + this.props.name}
            >
                {this.props.children}
            </button>
        )
    }

}