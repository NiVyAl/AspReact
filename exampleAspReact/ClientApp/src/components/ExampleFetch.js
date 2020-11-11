import React, { Component } from 'react';
import axios from 'axios';

export class ExampleFetch extends Component {
    static displayName = ExampleFetch.name;

    constructor(props) {
        super(props);
        this.state = {
            forecasts: [],
            loading: true,
            isAddData: false,
        };

        this.data = {
            name: "",
            surname: "",
            years: 0,
            isSubscribe: false,
		}
    }

    componentDidMount() {
        this.populateWeatherData();
    }

    sendForm = (e) => {
        e.preventDefault();

        if (!this.state.isAddData) {
            this.data = { name: "Иван", surname: "Иванов", years: 32, isSubscribe: true };
		}
        
        console.log(this.data);
        axios.post("example", this.data)
            .then(res => {
                console.log(res);
                console.log(res.data);
            });
    }

    handleChange = (e) => {
  //      if (e.target.id === "isSubscribe") {
  //          this.data.isSubscribe = !this.data.isSubscribe;
  //      } else if (e.target.id === "years") {
  //          this.data.years = parseInt(e.target.value, 10);
  //      } else {
  //          this.data[e.target.id] = e.target.value;
		//}
        switch (e.target.id) {
            case "isSubscribe":
                this.data.isSubscribe = !this.data.isSubscribe;
                break;
            case "years":
                this.data.years = parseInt(e.target.value, 10);
                console.log(typeof this.data.years);
                console.log(this.data.years);
                console.log(this.data);
                break;
            default:
                console.log(this.data);
                this.data[e.target.id] = e.target.value;

		}
        this.setState({ isAddData: true });
    }

    async populateWeatherData() {
        await axios.get("example/welcome", { params: { id: 12, name: "Иван" } })
            .then(res => {
                console.log(res.data);
                this.setState({ loading: false, data: res.data })
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

                <form onSubmit={this.populateWeatherData}>
                    <label htmlFor="name">Имя</label>
                    <input style={{ display: "block" }} id="name" onChange={this.handleChange} type="text" />

                    <label htmlFor="surname">Фамилия</label>
                    <input style={{ display: "block" }} id="surname" onChange={this.handleChange} type="text" />

                    <label htmlFor="years">Возраст</label>
                    <input style={{ display: "block" }} id="years" onChange={this.handleChange} type="number" />

                    <label htmlFor="isSubscribe">Согласен получать рекламную рассылку</label>
                    <input id="isSubscribe" onChange={this.handleChange} type="checkbox" />

                </form>
                <button onClick={this.sendForm}>
                    {this.state.isAddData &&
                        <React.Fragment>Отправить введенные данные</React.Fragment>
                    }
                    {this.state.isAddData == false &&
                        <React.Fragment>Отправить дефолтные данные</React.Fragment>
                    }
                </button>
            </div>
        );
    }
}
