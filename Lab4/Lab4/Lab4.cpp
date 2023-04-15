#include <SFML/Graphics.hpp>
#include <SFML/Window/Event.hpp>
#include <iostream>
#include <string>
#include <exception>


namespace Lab4
{
	using namespace sf;
	using namespace std;

	class FileNotFoundException : public invalid_argument
	{
		using invalid_argument::invalid_argument;
	};

	class Image :public Sprite
	{
	public:
		Image(const string& image_path)
		{
			if (!_texture.loadFromFile(image_path))
				throw FileNotFoundException(image_path);

			this->setTexture(_texture);
		};

		~Image()
		{

		}

	private:
		Texture _texture;

	};


	class Border :public RectangleShape
	{
	public:

		Border(Vector2f pos = { 0,0 }, Vector2f size = { 0,0 }) : RectangleShape(size)
		{
			this->setPosition(pos);
		}


		inline Rect<float> getRect()
		{
			return { this->getPosition(), this->getSize() };
		}

		void onEvent(const Event& e)
		{
			switch (e.type)
			{
			case Event::MouseButtonPressed:
				onMouseButtonPressed(e.mouseButton);
				break;
			case Event::MouseButtonReleased:
				onMouseButtonReleased(e.mouseButton);
				break;
			case Event::MouseMoved:
				onMouseMoved(e.mouseMove);
				break;
			default:
				break;
			}
		}
		void onMouseButtonReleased(const Event::MouseButtonEvent& e)
		{
			_movingState = false;
		}

		void onMouseMoved(const Event::MouseMoveEvent& e)
		{
			if (!_movingState)return;
			setPosition(_movingOffset + Vector2f(e.x, e.y));
		}

		void onMouseButtonPressed(const Event::MouseButtonEvent& e)
		{
			auto  rect = getRect();

			if (!rect.contains(e.x, e.y))return;

			if (e.button == Mouse::Left)
			{
				_movingState = true;
				_movingOffset = getPosition() - Vector2f(e.x, e.y);
			}
		}


		~Border()
		{

		}


	private:
		bool _movingState = false;
		Vector2f _movingOffset = { 0,0 };

	};

}




int main()
{
	using namespace Lab4;
	sf::RenderWindow window(sf::VideoMode(200, 200), "SFML works!");
	Border rect;
	rect.setSize({ 20,40 });
	rect.setPosition({ 20,40 });
	rect.setFillColor(sf::Color::Blue);
	rect.setOutlineThickness(2);
	rect.setOutlineColor(sf::Color::Green);

	Lab4::Image image("img.png");
	image.setPosition({ 50,100 });

	while (window.isOpen())
	{
		sf::Event event;
		while (window.pollEvent(event))
		{

			rect.onEvent(event);

			if (event.type == sf::Event::Closed)
				window.close();

			if (event.type == sf::Event::Resized)
			{
				// update the view to the new size of the window
				sf::FloatRect visibleArea(0, 0, event.size.width, event.size.height);
				window.setView(sf::View(visibleArea));
			}
		}

		window.clear();
		window.draw(rect);
		window.draw(image);
		window.display();
	}

	return 0;
}