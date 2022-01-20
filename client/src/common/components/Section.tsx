import { ReactNode } from 'react';

const Section: React.FC<SectionProps> = ({ children, options }) => {
	return <div className={`section ${options}`}>{children}</div>;
};

interface SectionProps {
	children: ReactNode;
	options?: string;
}

export default Section;
