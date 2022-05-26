import React, { Children } from "react";
import PropTypes from "prop-types";
import propTypes from "prop-types";

//Denna komponent renderar sina barn om man klickar på knappen. När knappen klickas på ändras this.state.show till true
// och en conditional rendering visar det barnet som finns.
export default class ReadMoreSection extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            show: false,
            status: "Läs mer",

        }
    }

    eventHandler = () => {
        if (this.state.show === false) {

            this.setState({ status: "Mindre", show: true });
        }
        else {
            this.setState({ status: "Läs mer", show: false });
        }
    }

    render() {
        return (
            <>
                {(this.state.show === true)
                    ?
                    < div >
                        {this.props.children}
                    </div>
                    :
                    <p></p>

                }
                <button onClick={this.eventHandler}>{this.state.status}</button>
            </>
        )
    }
}
