function [ reward ] = Reward( state )
%REWARD Summary of this function goes here
%   Detailed explanation goes here
    if(state(1) == 10 && state(2) == 4)
        reward = 100;
    else
        reward = -1;
    end


end

