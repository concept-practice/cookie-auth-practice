import React from 'react';
import { Col, Container, Row } from 'react-bootstrap';
import UsersIndex from '../features/users/UsersIndex';

const App: React.FC = () => {
	return (
		<Container>
			<UsersIndex />
		</Container>
	);
};

export default App;
