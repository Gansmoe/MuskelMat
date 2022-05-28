import React, { Component } from 'react'

const UserContext = React.createContext()

class UserProvider extends Component {
  // Context state
  state = {
    user: {
      name: "",
      isAdmin: false,
    },
    isLoading: true,
  }

  // Method to update state
  setUser = (user) => {
    this.setState((prevState) => ({ user }))
  }

  componentDidMount() {
    this.setState(prevState => {
      let user = Object.assign({}, prevState.user);
      user.isAdmin = JSON.parse(localStorage.getItem("isAdmin"));
      return { user };
    }, () => this.setState({ isLoading: false }))
  }


  render() {
    /* const { children } = this.props */
    const { user } = this.state
    const { setUser } = this
    console.log(this.state);
    return (
      <UserContext.Provider
        value={{
          user,
          setUser,
        }}
      >
      {(this.state.isLoading === true)
      ?
      <p>Laddar</p>
      :
      <>
      {this.props.children}
      </>
      }
      </UserContext.Provider>
    )
  }
}

export default UserContext

export { UserProvider }
