function [optimalPath, rec_temperature, computationTime ] = SimulatedAnnealing(dist_C2C, num_city, scale, limit )
%SIMULATEDANNEALING Summary of this function goes here
%   Detailed explanation goes here
    rec_temperature = [];

    % Step 1.
    % start from a random state
    path = randperm(num_city)'; % randomly generate a 
    minTemp = 1e+10;
    tic
    for time = 1 : limit
        % Step 2.
        % updata temperature
        temperature = ObjectF( dist_C2C, path);
        rec_temperature(time) = temperature; % recording

        % Step 3. 
        % randomly generate a successor state from current state
        newPath = RandInsert( path, num_city/5);

        newTemperature = ObjectF( dist_C2C, newPath);
        delta_E = newTemperature - temperature;
        if(delta_E < 0)
            path = newPath;
            if(newTemperature < minTemp)
                if(newTemperature < 4.9842e+03)
                    a = 1;
                end
                minTemp = newTemperature;
                optimalPath = path;
            end
        else
            P = scale * exp(-delta_E/temperature);
            if(rand() < P)
                path = newPath;
            end
        end
    end
    optimalPath(num_city+1) = optimalPath(1);

    computationTime = toc;

end

