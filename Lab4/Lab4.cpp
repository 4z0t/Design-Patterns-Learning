﻿#include <SFML/Graphics.hpp>
#include <SFML/Window/Event.hpp>







int main()
{
	sf::RenderWindow window(sf::VideoMode(200, 200), "SFML works!");
	sf::RectangleShape rect;
	rect.setOutlineThickness(2);
	rect.setOutlineColor(sf::Color::Green);


	while (window.isOpen())
	{
		sf::Event event;
		while (window.pollEvent(event))
		{



			if (event.type == sf::Event::Closed)
				window.close();
		}

		window.clear();
		window.draw(rect);
		window.display();
	}

	return 0;
}