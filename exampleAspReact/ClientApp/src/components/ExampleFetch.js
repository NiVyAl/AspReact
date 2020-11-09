import React, { Component } from 'react';
import axios from 'axios';

export class ExampleFetch extends Component {
    static displayName = ExampleFetch.name;

    constructor(props) {
        super(props);
        this.state = { forecasts: [], loading: true };
    }

    componentDidMount() {
        this.populateWeatherData();
    }

    sendForm() {
        let data = { name: "Иван", surname: "Иванов", years: 32, isSubscribe: true };
        console.log(data);
        axios.post("example", data)
            .then(res => {
                console.log(res);
                console.log(res.data);
            });
	}

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : <p>{this.state.data}</p>

        return (
            <div>
                <h1 id="tabelLabel" >Example fetch</h1>
                <p>Я создал это по фану</p>
                {contents}

                <button onClick={this.sendForm}>Отправить форму на сервер</button>
            </div>
        );
    }

    async populateWeatherData() {
        await axios.get("example/welcome", { params: { id: 12, name: "Иван" } })
            .then(res => {
                console.log(res.data);
                this.setState({ loading: false, data: res.data })
            });
    }
}
