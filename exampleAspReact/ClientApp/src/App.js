import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { ExampleFetch } from './components/ExampleFetch';
import { Counter } from './components/Counter';

import './custom.css'

export default class App extends Component {
    static displayName = App.name;

    static exampleFunction() {
        console.log("example");
	}

    render () {
        return (
            <Layout>
                <Route exact path='/' component={Home} />
                <Route path='/counter' component={Counter} />
                <Route path='/fetch-data' component={FetchData} />
                <Route path='/example-page' component={ExampleFetch} />
            </Layout>
        );
    }
}
