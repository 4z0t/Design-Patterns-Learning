#include <SFML/Graphics.hpp>
#include <SFML/Window/Event.hpp>
#include <iostream>
#include <string>
#include <exception>
#include <memory>


namespace Lab4
{
	using namespace sf;
	using namespace std;

	class FileNotFoundException : public invalid_argument
	{
		using invalid_argument::invalid_argument;
	};


	class AImage
	{
	public:
		AImage() {};
		virtual void setTexture(const string&) = 0;
		virtual void setPosition(const Vector2f&) = 0;
		virtual void setSize(const Vector2f&) = 0;
		virtual void draw(RenderWindow&) = 0;
		virtual ~AImage() {}
	};

	class Image :public Sprite, AImage
	{
	public:
		Image()
		{

		};

		virtual void setTexture(const string& path) override
		{
			if (!_texture.loadFromFile(path))
				throw FileNotFoundException(path);

			this->Sprite::setTexture(_texture);
		}

		virtual void setPosition(const Vector2f& pos) override
		{
			this->Sprite::setPosition(pos);
		}

		virtual void setSize(const Vector2f& size) override
		{
			auto texture_size = _texture.getSize();
			if (texture_size == Vector2u{ 0, 0 }) return;
			this->Sprite::setScale({ size.x / texture_size.x, size.y / texture_size.y });
		}

		virtual void draw(RenderWindow& window)override
		{
			window.draw(*this);
		}

		virtual ~Image()
		{

		}

	private:
		Texture _texture;
	};


	class Border : public RectangleShape, AImage
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
			case Event::KeyPressed:
				onKeyPressed(e.key);
				break;
			default:
				break;
			}
		}

		void onKeyPressed(const Event::KeyEvent& e)
		{
			auto curPpos = getSize();
			switch (e.code)
			{
			case Keyboard::Key::Up:
				setSize(curPpos + Vector2f{ 0, 1 });
				break;
			case Keyboard::Key::Down:
				setSize(curPpos + Vector2f{ 0, -1 });
				break;
			case Keyboard::Key::Right:
				setSize(curPpos + Vector2f{ 1, 0 });
				break;
			case Keyboard::Key::Left:
				setSize(curPpos + Vector2f{ -1, 0 });
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

			if (e.button == Mouse::Right)
			{
				if (_isRightCliked)
				{

					loadImage<Image>();
				}
				_isRightCliked = true;
			}
		}


		template<class T>
		void loadImage()
		{
			if (_image.get())
				return;

			_image = make_unique<T>();
			if (!_texture_path.empty())
				_image.get()->setTexture(_texture_path);
			_image.get()->setPosition(getPosition());
			_image.get()->setSize(getSize());

		}


		virtual void setTexture(const string& texture_path) override
		{
			_texture_path = texture_path;
			if (!_image.get())
				return;

			_image.get()->setTexture(_texture_path);
		}

		virtual void setPosition(const Vector2f& pos) override
		{
			this->RectangleShape::setPosition(pos);

			if (_image.get())
				_image.get()->setPosition(pos);
		}

		virtual void setSize(const Vector2f& size) override
		{
			this->RectangleShape::setSize(size);

			if (_image.get())
				_image.get()->setSize(size);
		}

		virtual void draw(RenderWindow& window)override
		{
			window.draw(*this);
			if (_image.get())
				_image.get()->draw(window);
		}


		~Border()
		{

		}

	private:
		bool _isRightCliked = false;
		bool _movingState = false;
		Vector2f _movingOffset = { 0,0 };
		string _texture_path;
		unique_ptr<Image> _image;
	};

}




int main()
{
	using namespace Lab4;
	sf::RenderWindow window(sf::VideoMode(200, 200), "SFML works!", sf::Style::Fullscreen);
	window.setFramerateLimit(60);
	Border rect;
	rect.setSize({ 200,200 });
	rect.setPosition({ 20,40 });
	rect.setFillColor(sf::Color::Black);
	rect.setOutlineThickness(2);
	rect.setOutlineColor(sf::Color::Green);
	rect.setTexture("img.png");

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
		rect.draw(window);
		window.display();
	}

	return 0;
}