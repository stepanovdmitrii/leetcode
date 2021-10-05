#include <vector>
#include <map>

/*
Даны даты заезда и отъезда каждого гостя. Для каждого гостя дата заезда строго раньше даты отъезда (то есть каждый гость останавливается хотя бы на одну ночь).
В пределах одного дня считается, что сначала старые гости выезжают, а затем въезжают новые.
Найти максимальное число постояльцев, которые одновременно проживали в гостинице (считаем, что измерение количества постояльцев происходит в конце дня).

sample = [ (1, 2), (1, 3), (2, 4), (2, 3), ]
*/

struct arrival_departure
{
    size_t arrival = 0;
    size_t departure = 0;
};


size_t max_guests(const std::vector<arrival_departure>& dates) {
    std::map<size_t, arrival_departure> schedule;
    for(const auto& date : dates) {
        schedule[date.arrival].arrival++;
        schedule[date.departure].departure++;
    }
    size_t max = 0;
    size_t current = 0;
    for(const auto& p : schedule) {
        current += p.second.arrival;
        current -= p.second.departure;
        if(current > max) {
            max = current;
        }
    }
    return max;
}
