import { Form } from 'react-bootstrap';

const UsersIndex: React.FC = () => {
	return (
		<Form>
			<Form.Group>
				<Form.Label>Email</Form.Label>
				<Form.Control type="email" placeholder="Enter email" />
			</Form.Group>
		</Form>
	);
};

export default UsersIndex;
